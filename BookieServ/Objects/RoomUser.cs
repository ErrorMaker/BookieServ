namespace BookieServ.Objects
{
  public class RoomUser
  {
		public int UniqueId;
        public string Username;
        public string Motto;
        public string Figure;
        public int VirtualId;
        public int PosX;
        public int PosY;
        public string PosZ;
        public int UserType; // 2 = user, 4 = bot
        public int DisplayType; // 1 = user, 2 = pet, 3 = bot
        public string Gender;
        public int GroupId; // 0 if none
        public int GroupUnknown; // no fucking idea what this is for
        public string GroupName;
        public string UnknownString; // again, dunno.
        public int AchievementScore;
        public bool UnknownBool; // dunno.
  }
}