using static System.Console;
using Airport_Class4.AirportRepo;

WriteLine("P.Diddy is a pedo");

// Landing Zones
var pad = new LandingPad("Pad");
var runway = new Runway("Runway");

// Mediator Construction
var tower = new ControlTower(pad, runway);

// Generating Vehicles
var chopper1 = new Helicopter(tower);
var chopper2 = new Helicopter(tower);
var chopper3 = new Helicopter(tower);
var plane1 = new Airplane(tower);
var plane2 = new Airplane(tower);
var plane3 = new Airplane(tower);

