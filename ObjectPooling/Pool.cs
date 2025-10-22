namespace PV.ObjectPooling;

public class Pool<T> where T : new()
{
    private readonly Queue<T> objectPool;

    public Pool(int maxCapacity)
    {
        this.objectPool = new Queue<T>(maxCapacity);
        this.InitPool();
    }

    private void InitPool()
    {
        for (var i = 0; i < this.objectPool.Capacity; i++)
            this.objectPool.Enqueue(new T());
    }

    public T Get() => this.objectPool.Count == 0 ? new T() : this.objectPool.Dequeue();

    public void Return(T obj)
    {
        if (this.objectPool.Count >= this.objectPool.Capacity) return;
        this.objectPool.Enqueue(obj);
    }
}
