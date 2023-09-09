namespace LeetCodeExercice;

public class LeetCodeExercice
{
    public LeetCodeExercice()
    {
        leetcodeTest();
    }
    public void leetcodeTest()
        {
            //Ex68();
            //Ex92();
            Ex118();
            //Ex138();
            //Ex168();
            //Ex225();
            //Ex383();
            //Ex403();
            //Ex412();
            //Ex459();
            //Ex646();
            //Ex767();
            //Ex876();
            //Ex1342();
            //Ex1480();
            //Ex1672();
            //Ex2366();
            //Ex2483();
        }

        #region ex68

        public void Ex68()
        {
            string[] wordsI1 = new string[]
            {
                "This", "is", "an", "example", "of", "text", "justification."
            };
            List<string> wordsO1 = new List<string>()
            {
                "This    is    an",
                "example  of text",
                "justification.  "
            };
            if (FullJustify(wordsI1, 16) != wordsO1)
                throw new Exception("ex 1 : faux");


            string[] wordsI2 = new string[]
            {
                "What", "must", "be", "acknowledgment", "shall", "be"
            };
            List<string> wordsO2 = new List<string>()
            {
                "What   must   be",
                "acknowledgment  ",
                "shall be        "
            };
            if (FullJustify(wordsI2, 16) != wordsO2)
                throw new Exception("ex 2 : faux");


            string[] wordsI3 = new string[]
            {
                "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.",
                "Art", "is", "everything", "else", "we", "do"
            };
            List<string> wordsO3 = new List<string>()
            {
                "Science  is  what we",
                "understand      well",
                "enough to explain to",
                "a  computer.  Art is",
                "everything  else  we",
                "do                  "
            };
            if (FullJustify(wordsI3, 20) != wordsO3)
                throw new Exception("ex 3 : faux");
        }
        //public static IList<string> FullJustify(string[] words, int maxWidth)
        //{
        //  List<string> phrase = new List<string>();
        //  List<List<string>> t = FielPhrase(words, maxWidth);

        //  throw new NotImplementedException("template");
        //}
        //public static List<List<string>> FielPhrase(string[] words, int maxWidth) 
        //{
        //  List<List<string>> phrase = new List<List<string>>();
        //  List<string> line = new List<string>();
        //  int LengthLine = 0;
        //  int WordNbrLine = 0;
        //  for(int i =0; i< words.Length; i++)
        //  {
        //    if(words[i].Length + LengthLine + WordNbrLine <= maxWidth)
        //    {
        //      //On peut ecrire dans la même ligne
        //      line.Add(words[i]);
        //      LengthLine+= words[i].Length;
        //      WordNbrLine++;
        //    }
        //    else
        //    {
        //      phrase.Add(line);
        //      line = new List<string>();
        //      WordNbrLine = 0;
        //      LengthLine = 0;
        //      //On peut ecrire dans la même ligne
        //      line.Add(words[i]);
        //      LengthLine += words[i].Length;
        //      WordNbrLine++;
        //    }

        //  }
        //  //On ajoute le dernière phrase 
        //  phrase.Add(line);
        //  return phrase;

        //}
        //public static string LeftJusify(List<string> phraseWord, int maxWidth)
        //{
        //  string line = string.Empty;
        //  foreach (string item in phraseWord)
        //  {
        //    line+= item + " ";
        //  }
        //  return line.PadRight(maxWidth, ' ');
        //  //lineToLeftJustify.PadRight(maxWidth,' ');
        //}
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var res = new List<string>();
            var cur = new List<string>();
            int num_of_letters = 0;

            foreach (var word in words)
            {
                if (word.Length + cur.Count + num_of_letters > maxWidth)
                {
                    for (int i = 0; i < maxWidth - num_of_letters; i++)
                    {
                        cur[i % (cur.Count - 1 > 0 ? cur.Count - 1 : 1)] += " ";
                    }

                    res.Add(string.Join("", cur));
                    cur.Clear();
                    num_of_letters = 0;
                }

                cur.Add(word);
                num_of_letters += word.Length;
            }

            string lastLine = string.Join(" ", cur);
            while (lastLine.Length < maxWidth) lastLine += " ";
            res.Add(lastLine);

            return res;
        }

        #endregion

        #region Ex92

        public void Ex92()
        {
            var i1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            var o1 = new ListNode(1)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            if (ReverseBetweenCorrection(i1,2,4) != o1)
                throw new Exception("ex 1 : faux");
        }

        // public ListNode ReverseBetween(ListNode head, int left, int right)
        // {
        //     ListNode lefListNode = head;
        //     ListNode rightListNode = head;
        //     ListNode result = head;
        //     int i = 1;
        //     while (head!= null)
        //     {
        //         if (i == left)
        //             lefListNode = head;
        //         else if (i == right)
        //             rightListNode = head;
        //         else
        //         
        //             result.val = head.val;
        //         head = head.next;
        //         i++;
        //     }
        //
        //     int k = 1;
        //     while (result!=null)
        //     {
        //         if (k == left)
        //             result.val = rightListNode.val;
        //         else if (k == right)
        //             result.val = lefListNode.val;
        //         k++;
        //     }
        // }

        public ListNode ReverseBetweenCorrection(ListNode head, int left, int right)
        {
            if (head == null || left == right) return head;
        
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode prev = dummy;
        
            for (int i = 0; i < left - 1; ++i) {
                prev = prev.next;
            }
        
            ListNode current = prev.next;
        
            for (int i = 0; i < right - left; ++i) {
                ListNode nextNode = current.next;
                current.next = nextNode.next;
                nextNode.next = prev.next;
                prev.next = nextNode;
            }
        
            return dummy.next;
        }
            
        #endregion

        #region Ex118
        public void Ex118()
        {
            var ex1 = Generate(5);
            var ex2 = Generate(1);

        }
        
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (numRows == 0)
                return result;
            
            result.Add(new List<int>(){1});
            for (int i = 2; i <= numRows; i++)
            {
                List<int> lastLine = result[result.Count - 1].ToList();
                List<int> line = new List<int>();
                for (int y = 0; y <= lastLine.Count; y++)
                {
                    if (y==0 || y==lastLine.Count)
                    {
                        line.Add(1);
                        continue;
                    }            
                    line.Add(lastLine[y-1]+lastLine[y]);
                }
                result.Add(line);
            }
            return result;
        }


        #endregion
        
        #region Ex138

        public void Ex138()
        {
            var t1 = CopyRandomList(new Node(1));


            var t2 = CopyRandomList(new Node(2));
            
            var t3 = CopyRandomList(new Node(3));
        }

        public Node CopyRandomList(Node head) {
            if (head == null) return null;
        
            Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
        
            Node curr = head;
            while (curr != null) {
                oldToNew[curr] = new Node(curr.val);
                curr = curr.next;
            }
        
            curr = head;
            while (curr != null) {
                oldToNew[curr].next = curr.next != null ? oldToNew[curr.next] : null;
                oldToNew[curr].random = curr.random != null ? oldToNew[curr.random] : null;
                curr = curr.next;
            }
        
            return oldToNew[head];
        }


        #endregion
        
        #region Ex141

        public void Ex141()
        {
            var i1 = new ListNode(3)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(0)
                    {
                        next = new ListNode(-4)
                    }
                }
            };
            if (!HasCycle(i1))
                throw new Exception("ex 1 : faux");
            
            var i2 = new ListNode(1)
            {
                next = new ListNode(2)
            };
            if (!HasCycle(i2))
                throw new Exception("ex 2 : faux");
            
            var i3 = new ListNode(1);
            if (HasCycle(i3))
                throw new Exception("ex 3 : faux");
        }

        public bool HasCycle(ListNode head)
        {
            ListNode slow_pointer = head, fast_pointer = head;
            while (fast_pointer != null && fast_pointer.next != null) {
                slow_pointer = slow_pointer.next;
                fast_pointer = fast_pointer.next.next;
                if (slow_pointer == fast_pointer) {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region ex168

        public void Ex168()
        {
            if (ConvertToTitle(1) != "A")
                throw new Exception("faux");
            if (ConvertToTitle(28) != "AB")
                throw new Exception("faux");
            if (ConvertToTitle(701) != "ZY")
                throw new Exception("faux");
        }

        public string ConvertToTitle(int columnNumber, string chaine = "")
        {
            if (columnNumber <= 0) return chaine;
            int colLettre = columnNumber % 26;
            chaine = ConvertNumToLettre(colLettre) + chaine;
            if (colLettre == 0)
                columnNumber--;
            return ConvertToTitle(columnNumber / 26, chaine);
        }

        public char ConvertNumToLettre(int num) => "ZABCDEFGHIJKLMNOPQRSTUVWXY"[num];

        #endregion

        #region ex225

        public void Ex225()
        {
            MyStack obj = new MyStack();
            obj.Push(1);
            obj.Push(2);
            var t = obj.Top();
            var p = obj.Pop();
            var o = obj.Empty();
        }

        #endregion

        #region ex383

        public void Ex383()
        {
            if (CanConstruct("a","b"))
                throw new Exception("ex 1 : faux");
            if (CanConstruct("aa", "ab"))
                throw new Exception("ex 2 : faux");
            if (!CanConstruct("aa","aab"))
                throw new Exception("ex 3 : faux");
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> dictMagazine = new Dictionary<char, int>();
            foreach (char c in magazine)
            {
                if (dictMagazine.ContainsKey(c))
                    dictMagazine[c]++;
                else
                {
                    dictMagazine.Add(c,1);
                }
            }

            foreach (char c in ransomNote)
            {
                if (dictMagazine.ContainsKey(c)&& dictMagazine[c]>0)
                    dictMagazine[c]--;
                else
                    return false;
            }

            return true;
        }     

        #endregion
        
        #region Ex412

        public void Ex412()
        {
            if (FizzBuzz(3).Equals(new List<string>(){"1","2","Fizz"}))
        throw new Exception("ex 1 : faux");
            if (FizzBuzz(5).Equals(new List<string>(){"1","2","Fizz","4","Buzz"}))
                throw new Exception("ex 2 : faux");
            if (FizzBuzz(15).Equals(new List<string>(){"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"}))
                throw new Exception("ex 3 : faux");
        }

        public IList<string> FizzBuzz(int n)
        {
            List<string> rep = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                bool canBeDividedBy3 = i % 3 == 0;
                bool canBeDividedBy5 = i % 5 == 0;
                string currString = String.Empty;
                if (canBeDividedBy3)
                    currString+="Fizz";
                if(canBeDividedBy5)
                    currString+="Buzz";
                if (currString == string.Empty)
                    currString = i.ToString();
                rep.Add(currString);
            }
            return rep;
        }


        #endregion

        #region ex403

        public void Ex403()
        {
            int[] ex1i = new int[] { 0, 1, 3, 5, 6, 8, 12, 17 };
            if (CanCrossResponse(ex1i) != true)
                throw new Exception("ex 1 : faux");

            int[] ex2i = new int[] { 0, 1, 2, 3, 4, 8, 9, 11 };
            if (CanCrossResponse(ex2i) != false)
                throw new Exception("ex 2 : faux");
            ;
        }

        public bool CanCross(int[] stones, int k = 0)
        {
            if (stones.Length <= 1) return true;

            int[] stonespossibilities = stones.Skip(1)
                .Where(x => stones[0] + k - 1 == x || stones[0] + k == x || stones[0] + k + 1 == x).ToArray();
            if (stonespossibilities.Length <= 0)
                return false;
            else //if (stonespossibilities.Length > 0)
            {
                foreach (int stone in stonespossibilities)
                {
                    int distance = stones[Array.IndexOf(stones, stone)] - stones[0];
                    if (CanCross(stones.Skip(Array.IndexOf(stones, stone)).ToArray(), distance))
                        return true;
                }

                return false;
            }
        }

        public bool CanCrossResponse(int[] stones)
        {
            int n = stones.Length;

            Dictionary<int, HashSet<int>> dp = new Dictionary<int, HashSet<int>>();
            foreach (int stone in stones)
            {
                dp[stone] = new HashSet<int>();
            }

            dp[0].Add(0);

            for (int i = 0; i < n; i++)
            {
                foreach (int k in dp[stones[i]])
                {
                    for (int step = k - 1; step <= k + 1; step++)
                    {
                        if (step != 0 && dp.ContainsKey(stones[i] + step))
                        {
                            dp[stones[i] + step].Add(step);
                        }
                    }
                }
            }

            return dp[stones[n - 1]].Count > 0;
        }

        #endregion

        #region ex459

        internal void Ex459()
        {
            bool ex1 = RepeatedSubstringPattern("abab");
            if (!ex1)
            {
                throw new Exception("ex 1 : faux");
            }

            bool ex2 = !RepeatedSubstringPattern("aba");
            if (!ex2)
            {
                throw new Exception("ex2 : faux");
            }

            bool ex3 = RepeatedSubstringPattern("abcabcabcabc");
            if (!ex3)
            {
                throw new Exception("ex3 : faux");
            }
        }
        //public static bool RepeatedSubstringPattern(string s)
        //{
        //  if (String.IsNullOrWhiteSpace(s)) return false;
        //  string sTemoin = string.Empty;
        //  foreach (char c in s.Substring(0,s.Length-1))
        //  {
        //    sTemoin += c;
        //    int sTemoinTimes = s.Length / sTemoin.Length;
        //    string sTemp = string.Empty;
        //    for (int i = 0; i < sTemoinTimes; i++)
        //      sTemp += sTemoin;

        //    if (sTemp == s)
        //      return true;
        //  }
        //  return false;
        //}
        public bool RepeatedSubstringPattern(string s)
        {
            string doubled = s + s;
            string sub = doubled.Substring(1, doubled.Length - 2);
            return sub.Contains(s);
        }

        //public bool RepeatedSubstringPattern(string s)
        //{
        //  int n = s.Length;
        //  for (int i = 1; i <= n / 2; i++)
        //  {
        //    if (n % i == 0)
        //    {
        //      string substring = s.Substring(0, i);
        //      System.Text.StringBuilder builder = new System.Text.StringBuilder();
        //      for (int j = 0; j < n / i; j++)
        //      {
        //        builder.Append(substring);
        //      }
        //      if (builder.ToString() == s) return true;
        //    }
        //  }
        //  return false;
        //}

        #endregion

        #region ex646

        public void Ex646()
        {
            int[][] i1 = new int[][]
            {
                new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }
            };
            if (FindLongestChain(i1) != 2)
                throw new Exception("faux");

            int[][] i2 = new int[][]
            {
                new int[] { 1, 2 }, new int[] { 7, 8 }, new int[] { 4, 5 }
            };
            if (FindLongestChain(i2) != 3)
                throw new Exception("faux");
        }

        public int FindLongestChain(int[][] pairs)
        {
            Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));

            int cur = int.MinValue, ans = 0;

            foreach (var pair in pairs)
            {
                if (cur < pair[0])
                {
                    cur = pair[1];
                    ans++;
                }
            }

            return ans;
        }

        #endregion

        #region ex725

        public void Ex725()
        {
            ListNode i1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                }
            };
            ListNode[] o1 = new ListNode[5]
            {
                new ListNode(1),
                new ListNode(2),
                new ListNode(3),
                null,null
            };
            if (SplitListToPartsCorrection(i1,5) != o1)
                throw new Exception("ex 1 : faux");
            
            ListNode i2 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)
                                {
                                    next = new ListNode(7)
                                    {
                                        next = new ListNode(8)
                                        {
                                            next = new ListNode(9)
                                            {
                                                next = new ListNode(10)
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            ListNode[] o2 = new ListNode[3]
            {
                new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                        }
                    }
                },
                new ListNode(5)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(7)
                    }
                },
                new ListNode(8)
                {
                    next = new ListNode(9)
                    {
                        next = new ListNode(10)
                    }
                }
            };
            
            if (SplitListToPartsCorrection(i2,3) != o2)
                throw new Exception("ex 2 : faux");
        }

        public ListNode[] SplitListToPartsCorrection(ListNode head, int k) {
            int length = 0;
            ListNode current = head;
            List<ListNode> parts = new List<ListNode>();

            while (current != null) {
                length++;
                current = current.next;
            }

            int base_size = length / k, extra = length % k;
            current = head;

            for (int i = 0; i < k; i++) {
                int part_size = base_size + (extra > 0 ? 1 : 0);
                ListNode part_head = null, part_tail = null;

                for (int j = 0; j < part_size; j++) {
                    if (part_head == null) {
                        part_head = part_tail = current;
                    } else {
                        part_tail.next = current;
                        part_tail = part_tail.next;
                    }

                    if (current != null) {
                        current = current.next;
                    }
                }

                if (part_tail != null) {
                    part_tail.next = null;
                }

                parts.Add(part_head);
                extra = System.Math.Max(extra - 1, 0);
            }

            return parts.ToArray();
        }


        #endregion
        
        #region ex767

        public void Ex767()
        {
            if (ReorganizeString("aab") != "aba")
                throw new Exception("faux");
            if (ReorganizeString("aaab") != "")
                throw new Exception("faux");
        }

        public string ReorganizeString(string s)
        {
            Dictionary<char, int> letterFrequency = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!letterFrequency.ContainsKey(c))
                    letterFrequency.Add(c, 0);
                letterFrequency[c]++;
            }

            List<char> sortedChars = new List<char>(letterFrequency.Keys);
            sortedChars.Sort((a, b) => letterFrequency[b].CompareTo(letterFrequency[a]));

            if (letterFrequency[sortedChars[0]] > (s.Length + 1) / 2) return string.Empty;

            char[] res = new char[s.Length];
            int i = 0;
            foreach (char c in sortedChars)
            {
                for (int j = 0; j < letterFrequency[c]; j++)
                {
                    if (i >= s.Length) i = 1;
                    res[i] = c;
                    i += 2;
                }
            }

            return new string(res);
        }

        #endregion

        #region ex876

        public void Ex876()
        { 
            ListNode i1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            var t1 = MiddleNode(i1);
            ListNode i2 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)
                            }
                        }
                    }
                }
            };
            var t2 = MiddleNode(i2);
        }
        public ListNode MiddleNode(ListNode head)
        {
            ListNode end = head;
            ListNode middle = head;
            
            while (end != null&& end.next !=null)
            {
                end = end.next.next;
                middle = middle.next;
            }

            return middle;

        }
        public ListNode MiddleNodeMoinsBien(ListNode head)
        {
            List<ListNode> listNodes = new List<ListNode>();
            while (head != null)
            {
                listNodes.Add(head);
                head = head.next;
            }
            return listNodes[listNodes.Count/2];

        }

        #endregion
        
        #region Ex1326

        public void Ex1326()
        {
            if (MinTapsCorrection(5, new int[] { 3, 4, 1, 1, 0, 0 }) != 1)
                throw new Exception("ex 1 : faux");
            if (MinTapsCorrection(3, new int[] { 0, 0, 0, 0 }) != -1)
                throw new Exception("ex 2 : faux");
        }

        public int MinTapsCorrection(int n, int[] ranges)
        {
            int[] arr = new int[n + 1];
            Array.Fill(arr, 0);

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] == 0) continue;
                int left = Math.Max(0, i - ranges[i]);
                arr[left] = Math.Max(arr[left], i + ranges[i]);
            }

            int end = 0, far_can_reach = 0, cnt = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i > end)
                {
                    if (far_can_reach <= end) return -1;
                    end = far_can_reach;
                    cnt++;
                }

                far_can_reach = Math.Max(far_can_reach, arr[i]);
            }

            return cnt + (end < n ? 1 : 0);
        }

        #endregion

        #region Ex1342

        public void Ex1342()
        {
            if (NumberOfSteps(14) != 6)
                throw new Exception("ex 1 : faux");
            if (NumberOfSteps(8) != 4)
                throw new Exception("ex 2 : faux");
            if (NumberOfSteps(123) != 12)
                throw new Exception("ex 3 : faux");
        }

        public int NumberOfSteps(int num)
        {
            int rep = 0;
            while (num!=0)
            {
                rep++;
                if (num % 2 == 0)
                    num /= 2;
                else
                    num -= 1;    
            }

            return rep;
        }
        public int NumberOfStepsByte(int num)
        {
            int rep = 0;
            while (num!=0)
            {
                rep++;
                if ((num & 1) == 0) //nums & 1 regarde si le dernier bits de num vaut 1 ou pas (pair ou impair)
                //num & 1101 compare la valeur binaire de num et de 1101(qui est en bytes) et quand les deux champs valent 1 cela retourne 1 sinon 0
                //Ex 111 0011 & 100 0101 retournerai 100 0001
                    num >>= 1; //Décaller de 1 bits un nombre vers la droite revient à le diviser par 2
                else
                    num --;
            }
            return rep;
        }


        #endregion
        
        #region Ex1480

        public void Ex1480()
        {
            if (RunningSum(new int[] { 1, 2, 3, 4 }) != new int[] { 1, 3, 6, 10 })
                throw new Exception("ex 1 : faux");
            if (RunningSum(new int[] { 1, 1, 1, 1, 1 }) != new int[] { 1, 2, 3, 4, 5 })
                throw new Exception("ex 2 : faux");
            if (RunningSum(new[] { 3, 1, 2, 10, 1 }) != new int[] { 3, 4, 6, 16, 17 })
                throw new Exception("ex 3 : faux");
        }

        public int[] RunningSum(int[] nums)
        {
            int[] t = new int [nums.Length];
            t[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                t[i] = nums[i] + t[i - 1];
            }

            return t;
        }

        #endregion
        
        #region Ex1672
public void Ex1672()
{
    var i1 = new int[][]
    {
        new int[]{1,2,3},
        new int[]{3,2,1}
    };
    if (MaximumWealth(i1) != 6)
        throw new Exception("ex 1 : faux");
    
    var i2 = new int[][]
    {
        new int[]{1,5},
        new int[]{7,3},
        new int[]{3,5}
    };
    if (MaximumWealth(i2) != 10)
        throw new Exception("ex 2 : faux");
    
    var i3 = new int[][]
    {
        new int[]{2,8,7},
        new int[]{7,1,3},
        new int[]{1,9,5}
    };
    if (MaximumWealth(i3) != 17)
        throw new Exception("ex 3 : faux");
}

public int MaximumWealth(int[][] accounts)
{
    int max = 0;
    
    foreach (int[] account in accounts)
    {
        int temp = 0;
            
        foreach (int money in account)
        {
            temp += money;
        }

        max = Math.Max(temp, max);
    }

    return max;
}

#endregion

        #region Ex2366

        public void Ex2366()
        {
            //if (MinimumReplacement(new int[] { 3, 9, 3 }) != 2)
            //  throw new Exception("ex 1 : faux");
            //if (MinimumReplacement(new int[] { 1, 2, 3, 4, 5 }) != 0)
            //  throw new Exception("ex 2 : faux");
            if (MinimumReplacementCorrection(new int[] { 12, 9, 7, 6, 17, 19, 21 }) != 6)
                throw new Exception("ex 2 : faux");
        }

        public long MinimumReplacement(int[] nums)
        {
            int t = nums[^2]; // pour prendre l'avant dernier élément d'un tableau

            int numsCountInitial = nums.Length;
            List<int> numsList = nums.ToList();
            numsList.Reverse();
            for (int i = 1; i < numsList.Count; i++)
            {
                if (numsList[i - 1] < numsList[i])
                {
                    //if (i<numsList.Count-1) 
                    numsList.Insert(i + 1, numsList[i] - numsList[i - 1]);
                    //else
                    //  numsList.Add(numsList[i] - numsList[i - 1]);
                    numsList[i] = numsList[i - 1];
                }
                else
                    continue;
            }

            return numsList.Count - numsCountInitial;
        }

        //Correction
        public long MinimumReplacementCorrection(int[] nums)
        {
            long operations = 0;
            long prev_bound = nums[^1];

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                long num = nums[i];
                long no_of_times = (num + prev_bound - 1) / prev_bound;
                operations += no_of_times - 1;
                prev_bound = num / no_of_times;
            }

            return operations;
        }

        #endregion

        #region Ex2483

        public void Ex2483()
        {
            if (BestClosingTime("YYNY") != 2)
                throw new Exception("ex 1 : faux");
            if (BestClosingTime("NNNNN") != 0)
                throw new Exception("ex 2 : faux");
            if (BestClosingTime("YYYY") != 4)
                throw new Exception("ex 3 : faux");
            if (BestClosingTime("NNYYYNNNNNNNNYYN") != 5)
                throw new Exception("ex 3 : faux");
        }

        public int BestClosingTime(string customers)
        {
            customers = customers.TrimEnd('N');
            int besthour = -1, max_score = 0, score = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                score = customers[i] == 'Y' ? score + 1 : score - 1;
                if (score > max_score)
                {
                    max_score = score;
                    besthour = i;
                }
            }

            return besthour + 1;
        }

        #endregion

        #region Template

        public void Exxxx()
        {
            if (MethodName() != "A")
                throw new Exception("ex 1 : faux");
            if (MethodName() != "AB")
                throw new Exception("ex 2 : faux");
            if (MethodName() != "ZY")
                throw new Exception("ex 3 : faux");
        }

        public string MethodName()
        {
            throw new NotImplementedException("template");
        }

        #endregion
    
}
    #region Ex138
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
#endregion
    
    #region Ex141

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    #endregion

    #region Ex225

    //public class MyStack
    //{
    //  private Queue<int> myQueue; //=> Queue un first in first out

    //  public Queue<int> MyQueue
    //  {
    //    get { return myQueue; }
    //    set { myQueue = value; }
    //  }


    //  public MyStack()
    //  {
    //    MyQueue = new Queue<int>();
    //  }

    //  public void Push(int x)
    //  {
    //    MyQueue.Enqueue(x);
    //  }

    //  public int Pop()
    //  {
    //    Queue<int> myQueueTemp = new Queue<int>();
    //    int MyQueueCount = MyQueue.Count;
    //    for (int i = 0; i < MyQueueCount; i++) {
    //      myQueueTemp.Enqueue(MyQueue.Dequeue());
    //    }

    //    int myQueueTempCount = myQueueTemp.Count;
    //    for (int i = 0; i< myQueueTempCount-1;i++)
    //    {
    //      this.Push(myQueueTemp.Dequeue());
    //    }
    //    int lastElement = myQueueTemp.Dequeue();
    //    return lastElement;
    //  }

    //  public int Top()
    //  {
    //    Queue<int> myQueueTemp = new Queue<int>();
    //    int MyQueueCount = MyQueue.Count;
    //    for (int i = 0; i < MyQueueCount; i++)
    //    {
    //      myQueueTemp.Enqueue(MyQueue.Dequeue());
    //    }
    //    int myQueueTempCount = myQueueTemp.Count;
    //    for (int i = 0; i < myQueueTempCount - 1; i++)
    //    {
    //      this.Push(myQueueTemp.Dequeue());
    //    }
    //    int lastElement = myQueueTemp.Dequeue();
    //    this.Push(lastElement);
    //    return lastElement;
    //  }

    //  public bool Empty()
    //  {
    //    if (MyQueue.Count <= 0)
    //      return true;
    //    else
    //      return false;
    //  }
    //}

    //Reponse
    public class MyStack
    {
        private Queue<int> q;

        public MyStack()
        {
            q = new Queue<int>();
        }

        public void Push(int x)
        {
            q.Enqueue(x);
            for (int i = 0; i < q.Count - 1; i++)
            {
                q.Enqueue(q.Dequeue());
            }
        }

        public int Pop()
        {
            return q.Dequeue();
        }

        public int Top()
        {
            return q.Peek();
        }

        public bool Empty()
        {
            return q.Count == 0;
        }
    }

    #endregion
