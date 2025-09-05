class Program
{
    static void Main(string[] args)
    {
        // 1. Instanciando (criando) um novo objeto Cachorro
        Cachorro meuCachorro = new Cachorro("Rex", 6);
        Cachorro meuCachorro2 = new Cachorro("Pe duro", 5);
        Cachorro meuCachorro3 = new Cachorro("Valdemar", 8);
        Cachorro meuCachorro4 = new Cachorro("Apolo", 10);

        // 2. Usando o método da classe para emitir o som
        meuCachorro.Emitirsom();
        meuCachorro2.Emitirsom();
        meuCachorro3.Emitirsom();
        meuCachorro4.Emitirsom();

    }
}
