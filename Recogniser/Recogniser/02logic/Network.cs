using System;

public class Network
{
    private int[] weights;
    private int[] biases;

    private const int connections;

    public Network(int[] weights, int[] biases) { 
        this.weights = weights;
        this.biases = biases;
        this.connections = weights.length;
    }

    public int feedForward(int a) {
        for (int i = 0; i < this.connections; i++)
        {
            
        }
    
    }
}
