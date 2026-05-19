using static System.Console;
using Airport_Class4.AirportRepo;


// Landing Zones
var pad = new LandingPad("Pad");
var runway = new Runway("Runway");

// Mediator Construction
var tower = new ControlTower(pad, runway);

// Generating Vehicles
var chopper1 = new Helicopter(tower, "L-1D0R");
var chopper2 = new Helicopter(tower,"T-0M3R");
var plane1 = new Airplane(tower, "DP-2026");
var plane2 = new Airplane(tower, "M-1K3");


chopper1.Send("Land");
plane1.Send("Land");
chopper2.Send("Land");
chopper1.Send("TakeOff");
plane1.Send("TakeOff");
chopper2.Send("Land");
plane2.Send("Land");
plane2.Send("TakeOff");