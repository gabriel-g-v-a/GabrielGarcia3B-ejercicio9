class MedAritmetica{
    public double num;
    public int Cont;
    public int Cont2;
    public double promedio;
    public double division;
    public double suma;
    public void OPmedAritmetica(){
        Cont=1;
        Cont2=1;
        do{
        Console.WriteLine("Escriba el "+Cont+" número");
        Cont++;
        num=Convert.ToInt32(Console.ReadLine());
        suma=suma+num;
        Cont2++;
        division=Cont2-2;
        promedio=suma/division;
        }while(num!=0);
        Console.WriteLine("La suma de los números es: "+suma+" y el promedio es: "+promedio);
    }
}