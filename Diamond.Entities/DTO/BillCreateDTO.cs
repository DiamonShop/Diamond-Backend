namespace Diamond.Entities.DTO
{
    public class BillCreateDTO
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string OrderNote { get; set; }
        public bool IsActive { get; set; }
    }
}
