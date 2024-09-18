
//CHAVE - VALOR
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MS", "Mato Grosso do Sul");
estados.Add("SP", "São Paulo");
estados.Add("RS", "Rio de janeiro");
estados.Add("BA", "Bahia");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Removendo Elemento---------");

estados.Remove("BA");//CHAVE
estados["SP"] = "São Paulo - Valor Alterado"; //Alterando Valor

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "SP";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor Existente: {chave}");
} else {
    Console.WriteLine($"Valor Não existe. É seguro adicionar a chave: {chave}");
}

Console.WriteLine(estados["MS"]);//Obtendo valor de uma chave