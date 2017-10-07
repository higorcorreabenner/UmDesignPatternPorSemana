﻿using System;

namespace TestesUnitarios._1.LojaVirtual.PrimeiroTeste
{

    public static class TestaMaiorEMenorReordenado
    {
        public static void Testar()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Add(new Produto("Geladeira", 450.0));
            carrinho.Add(new Produto("Liquidificador", 250.0));
            carrinho.Add(new Produto("Jogo de pratos", 70.0));
            carrinho.Imprimir();

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("O menor produto: " + algoritmo.Menor.Nome);
            Console.WriteLine("O maior produto: " + algoritmo.Maior.Nome);
        }
    }
}