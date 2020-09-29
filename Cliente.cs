using System;

class Cliente{
  public string Nome;
  public string Endereco;

  public void Agendamento(string sC, string nome, double valor){
    Console.Write("\n|-----------------------------------|");
    Console.Write("\n|Serviço contratado:   {0}   \n|Prestador do serviço: {1} \n|Valor a ser pago: {2}", sC, nome, valor);

  }

  public void Pagar(Cartao card, string chave, double valor){
  
    if(card.efetuarPagamento(valor,chave)){
      Console.Write("\nPAGAMENTO APROVADO");
    }else{
      Console.Write("\nPAGAMENTO RECUSADO");
  }

}

}