﻿namespace InterfaceExercicio
{
    class SalvarJson : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvar arquivo Json");
        }
        public override void Nome()
        {
            Console.WriteLine("Definir nome Xml");
        }
    }
}
