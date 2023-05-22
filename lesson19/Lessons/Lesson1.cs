using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson19.Lessons;
public static class Lesson1
{
    public static int OpenLock1(string[] deadends, string target)
    {
        HashSet<string> deadendSet = new HashSet<string>(deadends);
        HashSet<string> visited = new HashSet<string>();
        visited.Add("0000");

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("0000");

        int level = 0;

        while (queue.Count > 0)
        {
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                string current = queue.Dequeue();

                if (deadendSet.Contains(current))
                    continue;

                if (current == target)
                    return level;

                for (int j = 0; j < 4; j++)
                {
                    StringBuilder sb = new StringBuilder(current);

                    // Поворот вперед
                    char originalChar = sb[j];
                    sb[j] = originalChar == '9' ? '0' : (char)(originalChar + 1);
                    string next1 = sb.ToString();

                    // Поворот назад
                    sb[j] = originalChar == '0' ? '9' : (char)(originalChar - 1);
                    string next2 = sb.ToString();

                    if (!visited.Contains(next1) && !deadendSet.Contains(next1))
                    {
                        visited.Add(next1);
                        queue.Enqueue(next1);
                    }

                    if (!visited.Contains(next2) && !deadendSet.Contains(next2))
                    {
                        visited.Add(next2);
                        queue.Enqueue(next2);
                    }
                }
            }

            level++;
        }

        return -1; // Если не удалось открыть замок
    }
}

