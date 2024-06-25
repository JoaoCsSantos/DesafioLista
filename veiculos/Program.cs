
Carro c1 = new Carro();


Moto m1 = new Moto();


int[] notas = new int[5];

notas[0] = 90;
notas[1] = 85;
notas[2] = 88;
notas[3] = 92;
notas[4] = 95;

for (int i =0; i < notas.Length; i++)
{
    Console.WriteLine($"Nota aluno {i + 1}: {notas[i]}");
}

List<Veiculo> veiculos = new List<Veiculo>();

veiculos.Add(c1);
veiculos.Add(m1);


foreach (Veiculo veiculo in veiculos)
{
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();
}
