namespace pr_9_permilko.Classes
{
    public class Users
    {
        public long IdUser { get; set; }
        public List<Events> Events {get; set; }
        public Users(long idUser)
        {
            IdUser = idUser;
            Events = new List<Events>();        
        }
    }
}
