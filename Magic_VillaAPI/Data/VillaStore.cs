namespace Magic_VillaAPI.Models.Dto
{
    public class VillaStore
    
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto { ID = 1, Name = "Ocean View", CreatedDate = DateTime.Now, Occupancy=3, Sqft=56 },
            new VillaDto { ID = 2, Name = "Mountain Retreat", CreatedDate = DateTime.Now , Occupancy=5, Sqft=78}
        };
    }
}
