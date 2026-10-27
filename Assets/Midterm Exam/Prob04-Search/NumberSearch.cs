using System;

namespace MidtermExam.Prob04
{
    public class NumberSearch
    {
        // ใช้เวลา O(n) เพราะในกรณีที่แย่ที่สุด (Worst Case) ข้อมูลที่ต้องการค้นหาอยู่ตำแหน่งสุดท้ายหรือไม่มีอยู่เลย 
        // ทำให้ต้องวนลูปตรวจสอบสมาชิกทุกตัวใน array (จำนวน n ตัว) จึงมี Time Complexity เป็น O(n)
        public int AS04_SequentialSearch(int[] values, int target)
        {
            if (values == null || values.Length == 0) return -1;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target) return i;
            }
            return -1;
        }

        // ใช้เวลา O(log n) เพราะในแต่ละรอบของการค้นหา จะมีการลดขอบเขตข้อมูลลงประมาณครึ่งหนึ่งเสมอ
        // ทำให้จำนวนรอบที่ใช้ค้นหาสูงสุดคือ log ฐาน 2 ของ n จึงมี Time Complexity เป็น O(log n)
        public int AS05_BinarySearch(int[] sortedValues, int target)
        {
            if (sortedValues == null || sortedValues.Length == 0) return -1;
            
            int left = 0;
            int right = sortedValues.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (sortedValues[mid] == target)
                    return mid;
                else if (sortedValues[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            
            return -1;
        }
    }
}
