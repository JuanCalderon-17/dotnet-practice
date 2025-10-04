
namespace dotnetPractice
{
    class fechaDia
    {
        public void MostrarFecha(string[] args)
        {
            var now = DateTime.Now;
            var hoy = DateTime.Today;

            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(hoy.ToShortDateString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}