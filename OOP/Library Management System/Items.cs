using System;
namespace ItemsName
{
    public class Items
    {
        public string title { get; set; }
        public string SrNo { get; set; }
        public bool IsAvailable { get; set; }
        public Items(string title, string SrNo)
        {
            this.title = title;
            this.SrNo = SrNo;
            this.IsAvailable = true;

        }
    }
}