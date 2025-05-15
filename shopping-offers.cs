// 638. Shopping Offers   
// https://leetcode.com/problems/shopping-offers
// Medium 41.1%
// 272.99158187932136
// Submission: https://leetcode.com/submissions/detail/111729194/
// Runtime: 215 ms
// Your runtime beats 38.24 % of csharp submissions.

using System.Linq;
public class Solution {
    IList<int> price;
    IList<IList<int>> special;
    IList<int> needs;
            public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs) {
        this.price = price;
        this.special = special;
        this.needs = needs;
                int minPrice = 0;
        for (int i=0; i<price.Count; i++)
            minPrice += price[i] * needs[i];
                int[] tmpNeeds = needs.ToArray();
        int current = Dfs(tmpNeeds, 0, 0, minPrice);
        return current;
    }
        int Dfs(int[] needs, int ispecial, int cost, int currentMin)
    {
        if (cost >= currentMin)
            return currentMin;
        if (ispecial == special.Count)
        {
            int newPrice = cost;
            for (int i=0; i<price.Count; i++)
                newPrice += price[i] * needs[i];
            return Math.Min(newPrice, currentMin);
        }
                // Skip special
        int without = Dfs(needs, ispecial+1, cost, currentMin);
                // Try special
        int with = currentMin;
        bool ok = true;
        var spec = special[ispecial];
        for (int i=0; i<price.Count && ok; i++)
        {
            if (needs[i]<spec[i]) 
                ok = false;
        }
                        if (ok)
        {
            int[] needs2 = (int[]) needs.Clone();
            for (int i=0; i<price.Count; i++)
                needs2[i] -= spec[i];
            with = Dfs(needs2, ispecial, cost + spec[spec.Count-1], currentMin);            
        }
        return Math.Min(without, with);
    }
}
