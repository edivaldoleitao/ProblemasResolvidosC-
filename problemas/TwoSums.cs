public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int>valores = new Dictionary<int,int>();

        for(int i=0; i<nums.Length;i++)
        {
            //cur+x=target
            //x=target-cur
            int x = target-nums[i];
            if(valores.ContainsKey(x))
            {
                return new int[] {valores[x],i};
            }
            try{
                valores.Add(nums[i],i);
            }
            catch(Exception e){}
        }
        return null;
    }
}