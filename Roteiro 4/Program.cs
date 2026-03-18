// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico...");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento com Cartão de Crédito...");
    }
}

class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento via Pix...");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento via Boleto Bancário...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Pagamento> pagamentos = new List<Pagamento>();

        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());
        pagamentos.Add(new Pix());

        foreach (Pagamento pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
        }
    }
}



