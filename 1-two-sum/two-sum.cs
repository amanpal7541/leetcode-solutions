using System;
using System.Collections.Generic;

class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int required = target - nums[i];

            if (map.ContainsKey(required))
            {
                return new int[] { map[required], i };
            }

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}