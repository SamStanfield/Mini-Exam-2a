using System;

class MainClass {
  public static double Volume(int radius, int height){
    double volume = 3.14* radius * radius * height;
    return volume;
  }
  
  
  
  public static void Main (string[] args) {
    
    int r,h = 0;
    double VolumeofCylinder = 0;
    Console.WriteLine("Enter the radius and height of the cylinder.");
    r = Convert.ToInt32(Console.ReadLine());
    h = Convert.ToInt32(Console.ReadLine());
    VolumeofCylinder = Volume(r,h);
    Console.WriteLine("The volume of the Cylinder is " + VolumeofCylinder);

  }
}