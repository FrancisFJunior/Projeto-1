using System;

class Cartao{

  private string numero;
  public double Limite;

  public void Setnumero(string n){
    numero = n;
  }

  public string Getnumero(){
    return numero;
  }

  public bool efetuarPagamento(double valor, string chave){

    if(valor <= Limite && chave == numero){
      Limite-=valor;
      return true;
    }else{
      return false;
  }

  

  }


}