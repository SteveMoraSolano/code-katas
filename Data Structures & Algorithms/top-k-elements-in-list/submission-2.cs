public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var hash = new Dictionary<int,int>();
        List<int>[] buckets = new List<int>[nums.Length + 1];
        int[] result = new int[k];
        int count = 0;
        foreach(int num in nums){
            if (hash.ContainsKey(num)){
                hash[num]++;
            }
            else{
                hash[num] = 1;
            }
        }

        

        for(int i=0;i < buckets.Length;i++){
            buckets[i] = new List<int>();
        }

        foreach(var kvp in hash){
            buckets[kvp.Value].Add(kvp.Key);
        }

        if (count == k) return result;
        
        for(int i = buckets.Length - 1; count < k; i--){          
           foreach(int num in buckets[i]){
            result[count] = num; 
            count++;    
           }
        }
        return result;
    }
}
