using static System.Console;
using Airport_Class4.AirportRepo;

WriteLine("P.Diddy is a pedo");

// Landing Zones
var pad = new LandingPad("Pad");
var runway = new Runway("Runway");

// Mediator Construction
var tower = new ControlTower(pad, runway);

// Generating Vehicles
var chopper1 = new Helicopter(tower, "L-1D0R");
var chopper2 = new Helicopter(tower,"T-0N3R");
var chopper3 = new Helicopter(tower,"M-1K3");
var plane1 = new Airplane(tower, "DP-2026");
var plane2 = new Airplane(tower, "T-1LTAN");
var plane3 = new Airplane(tower, "AAA");