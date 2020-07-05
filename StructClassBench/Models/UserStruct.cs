namespace StructClassBench.Models
{
    public struct UserStruct : IUser
    {
        public long UserId { get; set; }
        public int UserNameId { get; set; }
        public int UserAge { get; set; }
        public decimal UserAccountValue { get; set; }
    }
}
