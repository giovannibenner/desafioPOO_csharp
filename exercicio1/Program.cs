using exercicio1;

Animal a = new Animal();
Cachorro c = new Cachorro();
Animal g = new Gato();
Animal p = new Passaro();

c.Raca = "Golden";

a.EmitirSom();
c.EmitirSom();
g.EmitirSom();
p.EmitirSom();

a.Comer(10.0);
c.Comer(15.0);
g.Comer(5.0);
p.Comer(0.5);