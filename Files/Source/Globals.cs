using System.Collections.Generic;

public class Globals
{
    public static int TERRAIN_LAYER_MASK = 1 << 8;

    public static BuildingData[] BUILDING_DATA = new BuildingData[]
    {
        new BuildingData("Hub", 100),
        new BuildingData("Bunks", 100),
        new BuildingData("generator", 100),
        new BuildingData("Landing Pad", 100),
        new BuildingData("Mine", 100),
        new BuildingData("Refinery", 100),
        new BuildingData("Solar Array", 100),
    };

    

    public static int workers = 50;

    public static int Workers()
    {
        return workers;
    }
    
   public static int rock = 0;
    public static int Rock()
    {
     

        return rock;
    }

    public static int power = 0;
    public static int Power()
    {
        

        return power;
    }
 
    public static int metal = 0;
    public static int Metal()
    {
       

        return metal;
    }

    public static int polymer = 0;
    public static int Polymer()
    {
        

        return polymer;
    }
}