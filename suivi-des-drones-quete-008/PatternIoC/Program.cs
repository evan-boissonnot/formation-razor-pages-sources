using PatternIoC;

Bus bus = new ();
Velo velo = new ();
VoitureElectrique voiture = new();

Person person = new("Igor", voiture);
person.AllerAuTravail(new("Far far away"));