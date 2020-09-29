using System;

class Servico{
  private string Funcao;
  private string Nome;
  private double Preco;
  
  public void SetFuncao(string f){
    Funcao = f;
  }

  public void SetNome(string n){
    Nome = n;
  }

  public void SetPreco(double p){
    Preco = p;
  }

  public string GetFuncao(){
    return Funcao;
  }

 public string GetNome(){
    return Nome;
  }

  public double GetPreco(){
    return Preco;
  }
  
  public string Disponibilidade(int codDisp){
    
    if(codDisp == 01){
      return "\n|Horario do serviço: 08:00|";
       
      }else if(codDisp == 02){
        return "\n|Horario do serviço: 10:30|";
        }else if(codDisp == 03){
          return "\n|Horario do serviço: 13:00|";
          }else if(codDisp == 04){
            return "\n|Horario do serviço: 15:00|";
            }  

            return "\n|Horario não existe!|";
  }

  public void Recibo(string nomecli,string sC, string nome, int codDisp, double valor, double limite){

    Console.Write("\n|---------- NOTA  FISCAL -----------|");
    Console.Write("\n|Nome do contratante:   {0} \n|Serviço contratado:   {1}   \n|Prestador do serviço: {2} {3} \n|Valor total pago: {4} \n|Limite disponivel: {5}\n",nomecli, sC, nome, Disponibilidade(codDisp),valor, limite);
    Console.Write("|-----------------------------------|");

  }

}
