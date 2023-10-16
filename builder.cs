namespace BUilder;

class PC
{
    public int ram;
    public int cpu;
    public string? gpu_name;

    public PC()
    {}
}

class Director
{
    public Director(){}

    public PC BuildPC(IPCBuilder builder)
    {
        builder.Reset();
        builder.SetCpu();
        builder.SetGpuName();
        builder.SetRam();
        return builder.GetPC();
    }
}

interface IPCBuilder
{
    public void Reset();
    public void SetRam();
    public void SetCpu();
    public void SetGpuName();
    public PC GetPC();
}

class GamingPCBuilder_00 : IPCBuilder
{
    public GamingPCBuilder_00(){}
    private PC pc = new();

    public void Reset()
    {
        pc = new PC();
    }
    public void SetRam()
    {
        pc.ram = 32;
    }

    public void SetCpu()
    {
        pc.cpu = 12;
    }

    public void SetGpuName()
    {
        pc.gpu_name = "RTX4090";
    }

    public PC GetPC()
    {
        return this.pc;
    }
}

class GamingPCBuilder_01 : IPCBuilder
{
    public GamingPCBuilder_01(){}
    private PC pc = new();

    public void Reset()
    {
        pc = new PC();
    }
    public void SetRam()
    {
        pc.ram = 16;
    }

    public void SetCpu()
    {
        pc.cpu = 8;
    }

    public void SetGpuName()
    {
        pc.gpu_name = "RTX4060";
    }

    public PC GetPC()
    {
        return this.pc;
    }
}