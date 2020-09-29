using System;

class MainClass {
  public static void Main () {
    //
    Cartao cardAna = new Cartao();
    cardAna.Setnumero("123");
    cardAna.Limite = 1000;

    Cliente Ana = new Cliente();
    Ana.Nome = "Ana Silva";
    Ana.Endereco = "Rua dos Rios 232";


    Servico CodDisponibilidade = new Servico();
    Servico NotaFiscal = new Servico();

    Servico Eletricista = new Servico();
    Eletricista.SetFuncao("Eletricista");
    Eletricista.SetNome("Luiz Paiva");
    Eletricista.SetPreco(40);

    Servico Pedreiro = new Servico();
    Pedreiro.SetFuncao("Pedreiro");
    Pedreiro.SetNome("Tulio Osmar");
    Pedreiro.SetPreco(100);

    Servico Faxina = new Servico();
    Faxina.SetFuncao("Faxina");
    Faxina.SetNome("Maria Souza");
    Faxina.SetPreco(80);
    
    double valorFinal = 0;

    //
    Console.WriteLine("\n|-------SERVIÇOS-------|");
    Console.WriteLine("|01         Eletricista|");
    Console.WriteLine("|02            Pedreiro|");
    Console.WriteLine("|03              Faxina|");
    Console.WriteLine("|----------------------|\n");
    
    Console.Write("Escolha um serviço pelo Numero:");
    int codServico = int.Parse(Console.ReadLine());

    Console.WriteLine("\n|----Disponibilidade---|");
    Console.WriteLine("|01               08:00|");
    Console.WriteLine("|02               10:30|");
    Console.WriteLine("|03               13:00|");
    Console.WriteLine("|04               15:00|");
    Console.WriteLine("|----------------------|\n");
    
    Console.Write("Escolha um horário disponível:");
    int codDisp = int.Parse(Console.ReadLine());

    //
    switch (codServico){
          case 01:
              Ana.Agendamento(Eletricista.GetFuncao(),Eletricista.GetNome(),Eletricista.GetPreco());
              valorFinal = Eletricista.GetPreco();
              //
              switch (codDisp){
                case 1:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
                case 2:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
                default:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
              }
              Console.Write("\n|01 para Confirmar Pagamento ou 02 para cancelar serviço|\n");
              int codconfirm = int.Parse(Console.ReadLine());
              Console.Clear();

              if(codconfirm == 01){
                Ana.Pagar(cardAna, cardAna.Getnumero(), valorFinal);
                NotaFiscal.Recibo(Ana.Nome,Eletricista.GetFuncao(),Eletricista.GetNome(),codDisp,Eletricista.GetPreco(),cardAna.Limite);
              }else if(codconfirm == 02){
                Console.Write("\n|SERVIÇO CANCELADO COM SUCESSO|\n");}
              break;
          case 02:
              Ana.Agendamento(Pedreiro.GetFuncao(),Pedreiro.GetNome(),Pedreiro.GetPreco());
              valorFinal = Pedreiro.GetPreco();
              //
              switch (codDisp){
                case 1:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
                case 2:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
                default:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
              }
              Console.Write("\n|01 para Confirmar Pagamento ou 02 para cancelar serviço|\n");
              int codconfirm2 = int.Parse(Console.ReadLine());
              Console.Clear();

              if(codconfirm2 == 01){
                Ana.Pagar(cardAna, cardAna.Getnumero(), valorFinal);
                NotaFiscal.Recibo(Ana.Nome,Pedreiro.GetFuncao(),Pedreiro.GetNome(),codDisp,Pedreiro.GetPreco(),cardAna.Limite);
              }else if(codconfirm2 == 02){
                Console.Write("\n|SERVIÇO CANCELADO COM SUCESSO|\n");}
              break;
          case 03:
              Ana.Agendamento(Faxina.GetFuncao(),Faxina.GetNome(),Faxina.GetPreco());
              valorFinal = Faxina.GetPreco();
              //
              switch (codDisp){
                case 1:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
                case 2:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
                default:
                    Console.Write(CodDisponibilidade.Disponibilidade(codDisp));
                    break;
              }
              Console.Write("\n|01 para Confirmar Pagamento ou 02 para cancelar serviço|\n");
              int codconfirm3 = int.Parse(Console.ReadLine());
              Console.Clear();

              if(codconfirm3 == 01){
                Ana.Pagar(cardAna, cardAna.Getnumero(), valorFinal);
                NotaFiscal.Recibo(Ana.Nome,Faxina.GetFuncao(),Faxina.GetNome(),codDisp,Faxina.GetPreco(),cardAna.Limite);
              }else if(codconfirm3 == 02){
                Console.Write("\n|SERVIÇO CANCELADO COM SUCESSO|\n");}
              break;
          default:
              Console.Clear();
              Console.Write("Nenhum serviço selecionado tente novamente!");
              break;
      }
   
  }
}
