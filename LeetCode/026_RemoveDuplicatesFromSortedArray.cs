/*
26. Remove Duplicates from Sorted Array   # 283

Given a sorted array, remove the duplicates in place such that each element appear only 
once and return the new length.

Do not allocate extra space for another array, you must do this in place with constant memory.

For example,
Given input array nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 
respectively. "It doesn't matter what you leave beyond the new length."
*/

using System;

public class Solution026
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null)
            return 0;
        int len = nums.Length;
        if (len < 2)
            return len;
        int pivot = 0;
        for (int i = 0; i < len; i++)
        {
            if (nums[pivot] != nums[i])
            {
                pivot++;
                nums[pivot] = nums[i];
            }
            // nums[curr] == nums[i],  i++
        }
        return pivot + 1;
    }
}