namespace ef.Model {
    public class CatagoryDetail {
        public int CatagoryDetailId { get; set; }

        public DateTime createDate {get; set;}

        public int CountProduct {get; set; }

        public Catagory Catagory {get; set; }
    }
}