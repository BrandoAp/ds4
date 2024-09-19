using Lab8_8;

class ClaseConcretaa1 : ClaseAbstracta 
{
    protected override string tomaValor()
    {
        return "ClaseConcreta1";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix} ClaseConcreta1";
    }
}
