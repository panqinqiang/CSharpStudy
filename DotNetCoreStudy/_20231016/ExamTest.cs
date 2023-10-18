namespace DotNetCoreStudy._20231016;

using System;
using System.Collections.Generic;

public class Exam
{
    public class MaterialData
    {
        public ItemData item;   // 合成所需的物品
        public int count;       // 合成所需的该物品的数量
    }

    public class ItemData
    {
        public int id;                          // 物品 ID
        public int count;                       // 当前拥有的物品数量
        public int costGold;                    // 合成该物品所需的金币
        public List<MaterialData> materialList; // 合成该物品所需的材料
    }

    /// <summary>
    /// 计算用 totalGold 金币最多可以合成的 item 装备的数量
    /// </summary>
    /// <param name="item">要合成的装备</param>
    /// <param name="totalGold">拥有的金币</param>
    /// <returns>可合成的 item 装备的最大数量</returns>
    public int Run(ItemData item, int totalGold)
    {
        return CalculateMaxCraft(item, totalGold, new Dictionary<string, int>());
    }

    private int CalculateMaxCraft(ItemData item, int totalGold, Dictionary<string, int> memo)
    {
        string key = item.id + "_" + totalGold;

        if (memo.ContainsKey(key))
            return memo[key];

        // 如果需要的材料数量为0，无法合成，返回0
        foreach (var materialData in item.materialList)
        {
            if (materialData.item != null && materialData.count > 0)
            {
                int requiredMaterialCount = materialData.count;
                int availableMaterialCount = CalculateMaxCraft(materialData.item, totalGold, memo);
                if (availableMaterialCount < requiredMaterialCount)
                {
                    memo[key] = 0;
                    return 0;
                }
            }
        }

        // 如果当前金币不足以合成装备，返回0
        if (totalGold < item.costGold)
        {
            memo[key] = 0;
            return 0;
        }

        int maxCrafted = item.count;
        
        if (item.materialList.Count == 0)
        {
            return item.count;
        }
        
        // 计算金币合成的最大数量
        int maxGoldCrafted = totalGold / item.costGold;

        // 计算材料合成的最大数量
        foreach (var materialData in item.materialList)
        {
            if (materialData.item != null && materialData.count > 0)
            {
                int maxMaterialCrafted = CalculateMaxCraft(materialData.item, totalGold, memo) / materialData.count;
                if (maxMaterialCrafted < maxCrafted || maxCrafted == 0)
                    maxCrafted = maxMaterialCrafted;
            }
        }

        // 最终结果取金币和材料合成的最小值
        memo[key] = Math.Min(maxGoldCrafted, maxCrafted);

        return memo[key];
    }
}
