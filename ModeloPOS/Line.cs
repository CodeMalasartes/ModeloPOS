using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloPOS
{
    public class Line
    {
        protected int LineId;
        public string NomeProduto;
        public int Quantidade;
        public decimal ValorUnitario;
        public decimal Total;

        //List<Line> saleLines = new List<Line>();

        public void ShowLines(List<Line> lines)
        {
            foreach (Line linha in lines)
            {
                //falta formatar o valor unitario e o total
                Console.WriteLine("Nome Produto: " + linha.NomeProduto + " Quantidade: " + linha.Quantidade
                                + " Valor Unitário: " + string.Format("{0:0.##}", linha.ValorUnitario)  + " Total: " + string.Format("{0:0.##}", linha.Total));
            }

        }
        public void AddLine(Line line)
        {
            LineId++;
            //saleLines.Add(line);
        }
        public void RemoveLine(int Id)
        {
            //saleLines.Remove(line);
        }
        public void UpdateLine(int id)
        {

        }

    }
}
