using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroop_Test {
    internal class Colors {
        private Dictionary<string, string> _colorList;

        public Colors() {
            _colorList = new Dictionary<string, string>() {
                { "Red", "红色" },
                { "Green", "青色" },
                { "Blue", "蓝色" },
                { "Purple", "紫色" },
                { "Yellow", "黄色" },
                { "Pink", "粉色" },
                { "Orange", "橙色" },
                { "Black", "黑色" }
            };
        }

        public Dictionary<string, string> ColorList {
            get { return _colorList; }
        }

        public void AddColor(string color_en, string color_cn) {
            _colorList[color_en] = color_cn;
        }

        public void RandomColor() {
            Random random = new Random();
            var shuffled = _colorList
                .OrderBy(x => random.Next())
                .ToDictionary(x => x.Key, x => x.Value);

            _colorList.Clear();
            foreach (var item in shuffled) {
                _colorList.Add(item.Key, item.Value);
            }
        }

        public List<string> ReturnEnglishColorList() {
            int i = 0;
            List<string> colorlist = new List<string>();
            foreach (string color in _colorList.Keys) {
                if (i < 4) {
                    colorlist.Add(color);
                    i++;
                }
            }
            return colorlist;
        }

        public List<string> ReturnChineseColorList() {
            int i = 0;
            List<string> colorlist = new List<string>();
            foreach (string color in _colorList.Values) {
                if (i < 4) {
                    colorlist.Add(color);
                    i++;
                }
            }
            return colorlist;
        }

        // Input Chinese Color, return English color
        public string GetEnglishColor(string color_cn) {
            foreach (var color in _colorList) {
                if (color.Value == color_cn) {
                    return color.Key;
                }
            }
            return string.Empty;
        }
    }
}
