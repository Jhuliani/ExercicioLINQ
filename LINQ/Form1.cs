namespace LINQ
{
    public partial class Form1 : Form
    {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_estados;

        public Form1()
        {
            #region Lista de nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Gabriel");
            lista_nomes.Add("Marcos");
            lista_nomes.Add("Gisele");
            lista_nomes.Add("Jhuliani");
            lista_nomes.Add("Samuel");
            lista_nomes.Add("Murilo");
            lista_nomes.Add("Matheus");
            lista_nomes.Add("Sara");
            lista_nomes.Add("Ana");
            lista_nomes.Add("Miguel");
            lista_nomes.Add("Mirtes");
            lista_nomes.Add("Gabriela");
            lista_nomes.Add("Gabriely");
            lista_nomes.Add("Gabes");
            lista_nomes.Add("Maria");
            lista_nomes.Add("Moana");
            lista_nomes.Add("José");
            lista_nomes.Add("Solange");
            lista_nomes.Add("Guimes");
            lista_nomes.Add("Gilson");
            lista_nomes.Add("Gomes");
            lista_nomes.Add("Pedro");
            #endregion

            #region Lista números
            lista_numeros = new List<int>();
            lista_numeros.Add(10);
            lista_numeros.Add(25);
            lista_numeros.Add(45);
            lista_numeros.Add(48);
            lista_numeros.Add(07);
            lista_numeros.Add(01);
            lista_numeros.Add(18);
            lista_numeros.Add(19);
            lista_numeros.Add(14);
            lista_numeros.Add(23);
            lista_numeros.Add(99);
            lista_numeros.Add(55);
            lista_numeros.Add(15);
            lista_numeros.Add(11);
            lista_numeros.Add(21);
            lista_numeros.Add(68);
            lista_numeros.Add(18);
            lista_numeros.Add(09);
            lista_numeros.Add(17);
            #endregion

            #region Lista Produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Teclado USB", 49.95);
            lista_produtos.Add("Teclado PS2", 45.95);
            lista_produtos.Add("Teclado Gamer", 60.95);
            lista_produtos.Add("Mouse", 50.95);
            lista_produtos.Add("Monitos", 29.95);
            lista_produtos.Add("Memória 16g", 19.95);
            lista_produtos.Add("Memória 08g", 09.95);
            lista_produtos.Add("Memória 04g", 05.95);
            lista_produtos.Add("Fone USB", 47.95);
            lista_produtos.Add("Processador", 28.95);
            lista_produtos.Add("Placa mãe", 119.95);
            lista_produtos.Add("Teclado Mecanico", 149.95);
            lista_produtos.Add("Gabinete MX", 99.95);
            lista_produtos.Add("Gabinete BX", 229.95);
            lista_produtos.Add("Gabinete JX", 498.95);
            lista_produtos.Add("Gabinete LX", 498.95);
            #endregion

            #region Lista Produtos
            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("Rio de Janeiro", "Brasil");
            lista_estados.Add("São Paulo", "Brasil");
            lista_estados.Add("New York", "Estados Unidos");
            lista_estados.Add("Porto", "Portugal");
            lista_estados.Add("Lisboa", "Portugal");
            lista_estados.Add("Rio Grande do Suk", "Brasil");
            #endregion
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //Obter a fonte
            //Criar consulta
            //Executar a consulta

            var res = from num in lista_numeros where num % 2 == 0 select num;
        }
    }
}