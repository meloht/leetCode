﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1901_1950
{
    public class _1912_DesignMovieRentalSystemAlg
    {
        struct Pair : IEquatable<Pair>
        {
            public int First { get; }
            public int Second { get; }

            public Pair(int first, int second)
            {
                First = first;
                Second = second;
            }

            public bool Equals(Pair other) => First == other.First && Second == other.Second;
            public override bool Equals(object obj) => obj is Pair other && Equals(other);
            public override int GetHashCode() => (First << 16) ^ Second;
        }

        public class MovieRentingSystem
        {
            private Dictionary<Pair, int> tPrice = new Dictionary<Pair, int>();
            private Dictionary<int, SortedSet<Pair>> tValid = new Dictionary<int, SortedSet<Pair>>();
            private SortedSet<(int price, int shop, int movie)> tRent = new SortedSet<(int, int, int)>();

            public MovieRentingSystem(int n, int[][] entries)
            {
                foreach (var entry in entries)
                {
                    var p = new Pair(entry[0], entry[1]);
                    tPrice[p] = entry[2];
                    if (!tValid.ContainsKey(entry[1]))
                    {
                        tValid[entry[1]] = new SortedSet<Pair>(Comparer<Pair>.Create((a, b) =>
                            a.First != b.First ? a.First.CompareTo(b.First) : a.Second.CompareTo(b.Second)));
                    }
                    tValid[entry[1]].Add(new Pair(entry[2], entry[0]));
                }
            }

            public IList<int> Search(int movie)
            {
                if (!tValid.ContainsKey(movie))
                {
                    return new List<int>();
                }
                return tValid[movie].Take(5).Select(p => p.Second).ToList();
            }

            public void Rent(int shop, int movie)
            {
                var p = new Pair(shop, movie);
                int price = tPrice[p];
                tValid[movie].Remove(new Pair(price, shop));
                tRent.Add((price, shop, movie));
            }

            public void Drop(int shop, int movie)
            {
                var p = new Pair(shop, movie);
                int price = tPrice[p];
                tValid[movie].Add(new Pair(price, shop));
                tRent.Remove((price, shop, movie));
            }

            public IList<IList<int>> Report()
            {
                return tRent.Take(5).Select(t => new List<int> { t.shop, t.movie }).ToList<IList<int>>();
            }
        }
    }
}
