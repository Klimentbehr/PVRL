using System;
using System.Collections.Generic;
using System.IO;
using Main;
using Newtonsoft.Json;

public class Vault
{
    public List<GunGeneration.Gun> Guns { get; private set; }
    public List<HealingItem> HealingItems { get; private set; }
    public List<ArmorGeneration.Armor> Armors { get; private set; }
    public Dictionary<string, Dictionary<string, List<string>>> Parts { get; private set; }
    public const string vaultFilePath = "vault.txt";

    public Vault()
    {
        Guns = new List<GunGeneration.Gun>();
        HealingItems = new List<HealingItem>();
        Armors = new List<ArmorGeneration.Armor>();
        Parts = new Dictionary<string, Dictionary<string, List<string>>>();
        LoadVault();
    }

    public void AddGun(GunGeneration.Gun gun)
    {
        Guns.Add(gun);
        SaveVault();
    }

    public void RemoveGun(GunGeneration.Gun gun)
    {
        Guns.Remove(gun);
        SaveVault();
    }

    public void AddHealingItem(HealingItem item)
    {
        HealingItems.Add(item);
        SaveVault();
    }

    public void RemoveHealingItem(HealingItem item)
    {
        HealingItems.Remove(item);
        SaveVault();
    }

    public void AddArmor(ArmorGeneration.Armor armor)
    {
        Armors.Add(armor);
        SaveVault();
    }

    public void RemoveArmor(ArmorGeneration.Armor armor)
    {
        Armors.Remove(armor);
        SaveVault();
    }

    public void AddParts(GunGeneration.Gun gun)
    {
        AddPart("UpperReceiver", gun.UpperReceiver);
        AddPart("Barrel", gun.Barrel);
        AddPart("LowerReceiver", gun.LowerReceiver);
        AddPart("BufferTube", gun.BufferTube);
        AddPart("Stock", gun.Stock);
        AddPart("Grip", gun.Grip);
        AddPart("Trigger", gun.Trigger);
    }

    public void AddPart(string partType, string part)
    {
        var partQuality = part.Split('.')[1];

        if (!Parts.ContainsKey(partType))
        {
            Parts[partType] = new Dictionary<string, List<string>>();
        }

        if (!Parts[partType].ContainsKey(partQuality))
        {
            Parts[partType][partQuality] = new List<string>();
        }

        Parts[partType][partQuality].Add(part);
        SaveVault();
    }

    public bool HasPart(string partType, string partQuality)
    {
        return Parts.ContainsKey(partType) && Parts[partType].ContainsKey(partQuality) && Parts[partType][partQuality].Count > 0;
    }

    public string GetPart(string partType, string partQuality)
    {
        if (HasPart(partType, partQuality))
        {
            var part = Parts[partType][partQuality][0];
            Parts[partType][partQuality].Remove(part);
            if (Parts[partType][partQuality].Count == 0)
            {
                Parts[partType].Remove(partQuality);
            }
            if (Parts[partType].Count == 0)
            {
                Parts.Remove(partType);
            }
            SaveVault();
            return part;
        }
        return null;
    }

    public void SaveVault()
    {
        try
        {
            var vaultData = new
            {
                Guns = Guns,
                HealingItems = HealingItems,
                Armors = Armors,
                Parts = Parts
            };

            string json = JsonConvert.SerializeObject(vaultData, Formatting.Indented);
            File.WriteAllText(vaultFilePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving vault: {ex.Message}");
        }
    }

    public void LoadVault()
    {
        try
        {
            if (File.Exists(vaultFilePath))
            {
                string json = File.ReadAllText(vaultFilePath);
                var vaultData = JsonConvert.DeserializeObject<dynamic>(json);
                Guns = JsonConvert.DeserializeObject<List<GunGeneration.Gun>>(vaultData.Guns.ToString()) ?? new List<GunGeneration.Gun>();
                HealingItems = JsonConvert.DeserializeObject<List<HealingItem>>(vaultData.HealingItems.ToString()) ?? new List<HealingItem>();
                Armors = JsonConvert.DeserializeObject<List<ArmorGeneration.Armor>>(vaultData.Armors.ToString()) ?? new List<ArmorGeneration.Armor>();
                Parts = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<string>>>>(vaultData.Parts.ToString()) ?? new Dictionary<string, Dictionary<string, List<string>>>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading vault: {ex.Message}");
            Guns = new List<GunGeneration.Gun>();
            HealingItems = new List<HealingItem>();
            Armors = new List<ArmorGeneration.Armor>();
            Parts = new Dictionary<string, Dictionary<string, List<string>>>();
        }
    }
}
