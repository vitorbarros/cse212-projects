public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // If the value equals current node's data, don't insert (no duplicates)
        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // Base case: if value equals current node's data, found it
        if (value == Data)
            return true;
        
        // Recursive case: search in appropriate subtree
        if (value < Data)
        {
            // Search in left subtree
            return Left != null && Left.Contains(value);
        }
        else
        {
            // Search in right subtree
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Base case: if this is a leaf node (no children), height is 1
        if (Left is null && Right is null)
            return 1;
        
        // Recursive case: height is 1 + max height of left and right subtrees
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}