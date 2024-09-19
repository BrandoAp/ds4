using Lab8_8;

class ClaseConcreta2 : ClaseAbstracta 
{
    protected override string tomaValor()
    {
        return "ClaseConcreta2";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix} ClaseConcreta2";
    }
}
