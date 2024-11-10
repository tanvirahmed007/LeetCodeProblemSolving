
//Moor's Voting Algorithm
//Time Complexity: O(n)
//Space Complexity: O(1)
public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 1;
        int candidate = nums[0];
        
        for(int i = 1; i < nums.Length; i++){
            
            if(nums[i] == candidate)
                count++;
            else{
                
                count--;
                if(count == 0){
                    
                    candidate = nums[i];
                    count = 1;
                }
            }
        }
        
        return candidate;
    }
}

//HashMap
//Time Complexity: O(n)
//Space Complexity: O(n)
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> Counter = new();
        //Count the frequency of each element
        for(int i = 0; i < nums.Length; i++){
            if(Counter.ContainsKey(nums[i]))
                Counter[nums[i]]++;
            else
                Counter[nums[i]] = 1;
        }
        //Return the element with the maximum frequency
        return Counter.MaxBy(x => x.Value).Key;
    }
}