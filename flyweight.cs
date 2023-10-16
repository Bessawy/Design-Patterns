namespace FlyWeight;

class TreeType
{
    private string[] shape;
    private int size; 

    public TreeType(string[] shape, int size)
    {
        this.shape = shape;
        this.size = size;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine("--------------------");
        for(int i = 0; i < shape.Length; ++i)
        {
            Console.WriteLine(shape[i]);
        }
    }    

}

class TreeTypeFactory
{
    public Dictionary<int, TreeType> templates = new();

    public TreeType GetTreeType(int size, string[] shape)
    {
        if(templates.ContainsKey(size))
            return templates[size];
        
        templates[size] = new TreeType(shape, size);
        return templates[size];
    }
}

class Tree
{
    int x;
    int y;
    TreeType treeType; 

    public Tree(int x, int y, TreeType treeType)
    {
        this.x = x;
        this.y = y;       
        this.treeType = treeType;
    }

    public void Draw()
    {
        treeType.Draw(this.x, this.y);
    }
}


class DrawTree
{
    public DrawTree()
    {}

    string[][] treeTemplates = {
            new string[] {  // Small Tree
                " && ",
                "&&&&",
                " || ",
                " || "
            },
            new string[] {  // Medium Tree
                "  &&&   ",
                " &&&&&  ",
                "&&&&&&& ",
                "  |||   ",
                "  |||   "
            },
        };

public void DrawTrees()
{
    TreeTypeFactory factory = new();
    TreeType type1 = factory.GetTreeType(1, treeTemplates[0]);
    TreeType type2 = factory.GetTreeType(1, treeTemplates[0]);
    TreeType type3 = factory.GetTreeType(2, treeTemplates[1]);

    if(type1 != type2)
        throw new Exception("Types are not the same");
    
    Tree[] tree1 = {
        new Tree(0, 0, type1),
        new Tree(1, 1, type2),
        new Tree(1, 1, type3),
        };
    
    foreach (var tree in tree1)
    {
        tree.Draw();
    }

}

}