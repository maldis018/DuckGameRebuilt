﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DuckGame
{
    public class BitmapFont : Transform
    {
        public float ySpacing = 0;
        private SpriteMap _texture;
        public static SpriteMap _japaneseCharacters;
        public int charcolorindex;
        public int startingcoloroverride = -1;
        public int startingcolorindex = -1;
        private static bool _mapInitialized = false;
        
        public static char[] _characters = new char[325]
        {
          ' ',
          '!',
          '"',
          '#',
          '$',
          '%',
          '&',
          '\'',
          '(',
          ')',
          '*',
          '+',
          ',',
          '-',
          '.',
          '/',
          '0',
          '1',
          '2',
          '3',
          '4',
          '5',
          '6',
          '7',
          '8',
          '9',
          ':',
          ';',
          '>',
          '=',
          '<',
          '?',
          '@',
          'A',
          'B',
          'C',
          'D',
          'E',
          'F',
          'G',
          'H',
          'I',
          'J',
          'K',
          'L',
          'M',
          'N',
          'O',
          'P',
          'Q',
          'R',
          'S',
          'T',
          'U',
          'V',
          'W',
          'X',
          'Y',
          'Z',
          '[',
          '\\',
          ']',
          '^',
          '_',
          '`',
          'a',
          'b',
          'c',
          'd',
          'e',
          'f',
          'g',
          'h',
          'i',
          'j',
          'k',
          'l',
          'm',
          'n',
          'o',
          'p',
          'q',
          'r',
          's',
          't',
          'u',
          'v',
          'w',
          'x',
          'y',
          'z',
          '{',
          '|',
          '}',
          '~',
          '`',
          'À',
          'Á',
          'Â',
          'Ã',
          'Ä',
          'Å',
          'Æ',
          'Ç',
          'È',
          'É',
          'Ê',
          'Ë',
          'Ì',
          'Í',
          'Î',
          'Ï',
          'Ð',
          'Ñ',
          'Ò',
          'Ó',
          'Ô',
          'Õ',
          'Ö',
          'Ø',
          'Ù',
          'Ú',
          'Û',
          'Ü',
          'Ý',
          'Þ',
          'ß',
          'à',
          'á',
          'â',
          'ã',
          'ä',
          'å',
          'æ',
          'ç',
          'è',
          'é',
          'ê',
          'ë',
          'ì',
          'í',
          'î',
          'ï',
          'ð',
          'ñ',
          'ò',
          'ó',
          'ô',
          'õ',
          'ö',
          'ø',
          'ù',
          'ú',
          'û',
          'ü',
          'ý',
          'þ',
          'ÿ',
          'Ā',
          'ā',
          'Ă',
          'ă',
          'Ą',
          'ą',
          'Ć',
          'ć',
          'Ċ',
          'ċ',
          'Č',
          'č',
          'Ď',
          'ď',
          'Ē',
          'ē',
          'Ę',
          'ę',
          'Ě',
          'ě',
          'Ğ',
          'ğ',
          'Ġ',
          'ġ',
          'Ģ',
          'ģ',
          'Ħ',
          'ħ',
          'Ī',
          'ī',
          'Į',
          'į',
          'İ',
          'ı',
          'Ĳ',
          'ĳ',
          'Ķ',
          'ķ',
          'Ĺ',
          'ĺ',
          'Ļ',
          'ļ',
          'Ľ',
          'ľ',
          'Ł',
          'ł',
          'Ń',
          'ń',
          'Ņ',
          'ņ',
          'Ň',
          'ň',
          'Ō',
          'ō',
          'Ő',
          'ő',
          'Œ',
          'œ',
          'Ŕ',
          'ŕ',
          'Ř',
          'ř',
          'Ś',
          'ś',
          'Ş',
          'ş',
          'Š',
          'š',
          'Ţ',
          'ţ',
          'Ť',
          'ť',
          'Ū',
          'ū',
          'Ů',
          'ů',
          'Ű',
          'ű',
          'Ų',
          'ų',
          'Ÿ',
          'Ź',
          'ź',
          'Ż',
          'ż',
          'Ž',
          'ž',
          'ǅ',
          'ǆ',
          'ǲ',
          'ǳ',
          'А',
          'Б',
          'В',
          'Г',
          'Д',
          'Е',
          'Ж',
          'З',
          'И',
          'Й',
          'К',
          'Л',
          'М',
          'Н',
          'О',
          'П',
          'Р',
          'С',
          'Т',
          'У',
          'Ф',
          'Х',
          'Ц',
          'Ч',
          'Ш',
          'Щ',
          'Ъ',
          'Ы',
          'Ь',
          'Э',
          'Ю',
          'Я',
          'а',
          'б',
          'в',
          'г',
          'д',
          'е',
          'ж',
          'з',
          'и',
          'й',
          'к',
          'л',
          'м',
          'н',
          'о',
          'п',
          'р',
          'с',
          'т',
          'у',
          'ф',
          'х',
          'ц',
          'ч',
          'ш',
          'щ',
          'ъ',
          'ы',
          'ь',
          'э',
          'ю',
          'я',
          '¡',
          '¿',
          'Ё',
          'ё',
          'Ґ',
          'ґ',
          'Є',
          'є',
          'І',
          'і',
          'Ї',
          'ї'
        };
        private static int[] _characterMap = new int[ushort.MaxValue];
        private const int kTilesPerRow = 16;
        private int _tileSize = 8;
        public int fallbackIndex;
        private BitmapFont _fallbackFont;
        private InputProfile _inputProfile;
        private Sprite _titleWing;
        private int _maxWidth;
        public bool allowBigSprites;
        private int _letterIndex;
        public bool singleLine;
        public bool enforceWidthByWord = true;
        private Color _previousColor;
        public int characterYOffset;
        public Vec2 spriteScale = new Vec2(1f, 1f);
        public Color colorOverride;
        public char spritechar = '@';
        public char colorchar = '|';
        public float height => _texture.height * scale.y;

        public InputProfile inputProfile
        {
            get => _inputProfile;
            set => _inputProfile = value;
        }

        public int maxWidth
        {
            get => _maxWidth;
            set => _maxWidth = value;
        }

        public BitmapFont(string image, int size, int ysize = -1)
        {
            FancyBitmapFont.InitializeKanjis();
            if (ysize < 0)
                ysize = size;
            _texture = new SpriteMap(image, size, ysize);
            _tileSize = size;
            if (!_mapInitialized)
            {
                for (int index2 = 0; index2 < _characters.Length; ++index2)
                {
                    char ch = _characters[index2];
                    _characterMap[ch] = index2;
                }
                _mapInitialized = true;
            }
            _titleWing = new Sprite("arcade/titleWing");
        }

        public Sprite ParseSprite(string text, InputProfile input)
        {
            if (!allowBigSprites && text.StartsWith("_!"))
                return null;
            ++_letterIndex;
            string trigger = "";
            for (; _letterIndex != text.Length && text[_letterIndex] != ' ' && text[_letterIndex] != spritechar; ++_letterIndex)
                trigger += text[_letterIndex].ToString();
            Sprite sprite = null;
            if (input != null)
            {
                sprite = input.GetTriggerImage(trigger);
                if (sprite == null && Triggers.IsTrigger(trigger))
                    return new Sprite();
            }

            if (sprite == null)
                sprite = Input.GetTriggerSprite(trigger);

            Sprite spriteClone = null;
            if (sprite != null)
            {
                spriteClone = sprite.Clone();
                spriteClone.xscale = sprite.xscale * xscale;
                spriteClone.yscale = sprite.yscale * yscale;
            }
            
            return spriteClone;
        }

        public Color ParseColor(string text)
        {
            ++_letterIndex;
            string color = "";
            for (; _letterIndex != text.Length && text[_letterIndex] != ' ' && text[_letterIndex] != colorchar; ++_letterIndex)
                color += text[_letterIndex].ToString();
            if (color == "PREV")
            {
                return new Color(_previousColor.r, _previousColor.g, _previousColor.b);
            }
            else
            {
                return Colors.ParseColor(color);
            }
        }

        public InputProfile GetInputProfile(InputProfile input)
        {
            if (input == null)
                input = _inputProfile != null ? _inputProfile : InputProfile.FirstProfileWithDevice;
            return input;
        }

        public float GetWidth(string text, bool thinButtons = false, InputProfile input = null)
        {
            text = LangHandler.Convert(text);
            bool flag1 = false;
            if (input == null)
            {
                if (!MonoMain.started)
                {
                    input = InputProfile.DefaultPlayer1;
                }
                else
                {
                    input = _inputProfile != null ? _inputProfile : Input.lastActiveProfile;
                    if (_inputProfile == null && !Network.isActive)
                    {
                        Profile profileWithInput = Profiles.GetLastProfileWithInput();
                        if (profileWithInput != null)
                        {
                            input = profileWithInput.inputProfile;
                        }
                    }
                }
            }
            float num = 0f;
            float width = 0f;
            for (_letterIndex = 0; _letterIndex < text.Length; ++_letterIndex)
            {
                bool flag2 = false;
                if (text[_letterIndex] == spritechar)
                {
                    int letterIndex = _letterIndex;
                    Sprite sprite = ParseSprite(text, input);
                    if (sprite != null)
                    {
                        if (sprite.texture != null)
                        {
                            num += !thinButtons || flag1 ? (float)(sprite.width * sprite.scale.x + 1f) : 6f;
                            flag1 = true;
                        }
                        flag2 = true;
                    }
                    else
                        _letterIndex = letterIndex;
                }
                else if (text[_letterIndex] == colorchar)
                {
                    int letterIndex = _letterIndex;
                    if (ParseColor(text) != Colors.Transparent)
                        flag2 = true;
                    else
                        _letterIndex = letterIndex;
                }
                else if (text[_letterIndex] == '\n')
                {
                    if (num > width)
                        width = num;
                    num = 0f;
                }
                if (!flag2)
                    num += _tileSize * scale.x;
            }
            if (num > width)
                width = num;
            return width;
        }

        public List<string> ParseToList(string text)
        {
            text = LangHandler.Convert(text);
            List<string> result = new List<string>();
            for (_letterIndex = 0; _letterIndex < text.Length; ++_letterIndex)
            {
                bool processedSpecialCharacter = false;
                if (text[_letterIndex] == spritechar)
                {
                    int letterIndex = _letterIndex;
                    Sprite sprite = ParseSprite(text, null);
                    if (sprite != null)
                    {
                        result.Add(text.Substring(letterIndex, _letterIndex - letterIndex + (_letterIndex == text.Length ? 0 : 1)));
                        processedSpecialCharacter = true;
                    }
                    else
                        _letterIndex = letterIndex;
                }
                else if (text[_letterIndex] == colorchar)
                {
                    int letterIndex = _letterIndex;
                    if (ParseColor(text) != Colors.Transparent)
                    {
                        result.Add(text.Substring(letterIndex, _letterIndex - letterIndex + (_letterIndex == text.Length ? 0 : 1)));
                        processedSpecialCharacter = true;
                    }
                    else
                        _letterIndex = letterIndex;
                }
                if (!processedSpecialCharacter)
                {
                    result.Add(text[_letterIndex].ToString());
                }
            }

            return result;
        }

        public string ComposeToText(List<string> list)
        {
            return String.Join("", list);
        }

        protected int GetCompLength(string comp)
        {
            if (comp.Length == 1)
                return 1;
            if (comp[0] == spritechar)
                return 2;
            return 0;
        }

        public int GetLength(string text)
        {
            List<string> li = ParseToList(text);
            int length = 0;
            foreach (string comp in li)
                length += GetCompLength(comp);
            return length;
        }

        public string Crop(string text, int from, int to)
        {
            if (to < from || to > text.Length - 1)
                return "";
            List<string> li = ParseToList(text);
            List<string> cropped = new List<string>();
            int pos = 0;
            string firstColorTag = null;
            foreach (string comp in li)
            {
                if (pos >= to)
                    break;
                if (pos >= from)
                    cropped.Add(comp);
                else if (comp[0] == colorchar)
                    firstColorTag = comp;
                pos += GetCompLength(comp);
            }
            if (firstColorTag != null)
                cropped.Insert(0, firstColorTag);
            return ComposeToText(cropped);
        }

        public void DrawOutline(string text, Vec2 pos, Color c, Color outline, Depth deep = default(Depth))
        {
            string cleanText = text.CleanFormatting(Extensions.CleanMethod.Color);
            Draw(cleanText, pos + new Vec2(-1f * scale.x, 0f), outline, deep + 2, colorSymbols: true);
            Draw(cleanText, pos + new Vec2(1f * scale.x, 0f), outline, deep + 2, colorSymbols: true);
            Draw(cleanText, pos + new Vec2(0f, -1f * scale.y), outline, deep + 2, colorSymbols: true);
            Draw(cleanText, pos + new Vec2(0f, 1f * scale.y), outline, deep + 2, colorSymbols: true);
            Draw(cleanText, pos + new Vec2(-1f * scale.x, -1f * scale.y), outline, deep + 2, colorSymbols: true);
            Draw(cleanText, pos + new Vec2(1f * scale.x, -1f * scale.y), outline, deep + 2, colorSymbols: true);
            Draw(cleanText, pos + new Vec2(-1f * scale.x, 1f * scale.y), outline, deep + 2, colorSymbols: true);
            Draw(cleanText, pos + new Vec2(1f * scale.x, 1f * scale.y), outline, deep + 2, colorSymbols: true);
            Draw(text, pos, c, deep + 5);
        }

        public void Draw(
          string text,
          Vec2 pos,
          Color c,
          Depth deep = default(Depth),
          InputProfile input = null,
          bool colorSymbols = false)
        {
            Draw(text, pos.x, pos.y, c, deep, input, colorSymbols);
        }
        public void Draw(
          string text,
          float xpos,
          float ypos,
          Color c,
          Depth deep = default(Depth),
          InputProfile input = null,
          bool colorSymbols = false)
        {
            //if (!LangHandler.drawnstrings.Contains(text) && !LangHandler.langmap["en"].ContainsKey(text))
            //{
            //    LangHandler.drawnstrings.Add(text);
            //}
            text = LangHandler.Convert(text);
            if (colorOverride != default)
                c = colorOverride;
            _previousColor = c;
            Color color = c;
            if (input == null)
            {
                if (!MonoMain.started)
                {
                    input = InputProfile.DefaultPlayer1;
                }
                else
                {
                    input = _inputProfile != null ? _inputProfile : Input.lastActiveProfile;
                    if (_inputProfile == null && !Network.isActive)
                    {
                        Profile profileWithInput = Profiles.GetLastProfileWithInput();
                        if (profileWithInput != null)
                        {
                            input = profileWithInput.inputProfile;
                        }
                    }
                }
            }
            float num1 = 0f;
            float num2 = 0f;
            for (_letterIndex = 0; _letterIndex < text.Length; ++_letterIndex)
            {
                bool flag = false;
                if (text[_letterIndex] == spritechar)
                {
                    int letterIndex = _letterIndex;
                    Sprite sprite1 = ParseSprite(text, input);
                    if (sprite1 != null)
                    {
                        if (sprite1.texture != null)
                        {
                            float alpha = sprite1.alpha;
                            sprite1.alpha = this.alpha * c.ToVector4().w;
                            if (sprite1 != null)
                            {
                                Vec2 scale = sprite1.scale;
                                Sprite sprite2 = sprite1;
                                sprite2.scale *= spriteScale;
                                float num3 = (int)(_texture.height * spriteScale.y / 2f) - (int)(sprite1.height * spriteScale.y / 2f);
                                if (sprite1.moji)
                                {
                                    if (sprite1.height == 28)
                                    {
                                        Sprite sprite3 = sprite1;
                                        sprite3.scale *= (0.25f * this.scale);
                                        num3 += 10f * this.scale.y;
                                    }
                                    else
                                    {
                                        Sprite sprite4 = sprite1;
                                        sprite4.scale *= (0.25f * this.scale);
                                        num3 += 3f * this.scale.y;
                                    }
                                }
                                if (colorSymbols) sprite1.color = c;
                                Graphics.Draw(sprite1, xpos + num2, ypos + num1 + num3, deep);
                                num2 += (sprite1.width * sprite1.scale.x + 1f);
                                sprite1.scale = scale;
                                sprite1.color = Color.White;
                            }
                            sprite1.alpha = alpha;
                        }
                        flag = true;
                    }
                    else
                        _letterIndex = letterIndex;
                }
                else if (text[_letterIndex] == colorchar)
                {
                    int iPos2 = _letterIndex;
                    Color col = ParseColor(text);
                    if (colorOverride != default(Color))
                    {
                        col = colorOverride;
                    }
                    if (col != Colors.Transparent)
                    {
                        _previousColor = c;
                        float al2 = c.ToVector4().w;
                        c = col;
                        c *= al2;
                        flag = true;
                    }
                    else
                    {
                        _letterIndex = iPos2;
                    }
                }
                if (!flag)
                {
                    if (maxWidth > 0)
                    {
                        string source = "";
                        int letterIndex = _letterIndex;
                        while (letterIndex < text.Length && text[letterIndex] != ' ' && text[letterIndex] != colorchar && text[letterIndex] != spritechar)
                        {
                            source += text[letterIndex].ToString();
                            ++letterIndex;
                            if (!enforceWidthByWord)
                                break;
                        }
                        if (num2 + source.Length * (_tileSize * scale.x) > maxWidth)
                        {
                            num1 += _texture.height * scale.y;
                            num2 = 0f;
                            if (singleLine)
                                break;
                        }
                    }
                    if (text[_letterIndex] == '\n')
                    {
                        num1 += _texture.height * scale.y + ySpacing;
                        num2 = 0f;
                    }
                    else
                    {
                        SpriteMap g = _texture;
                        char index = text[_letterIndex];
                        int num4;
                        if (index >= 'ぁ')
                        {
                            g = FancyBitmapFont._kanjiSprite;
                            num4 = FancyBitmapFont._kanjiMap[index];
                        }
                        else
                        {
                            num4 = _characterMap[index];
                            if (num4 == 0 && index != ' ')
                            {
                                num4 = 91;
                            }
                        }
                        if (fallbackIndex != 0 && num4 >= fallbackIndex)
                        {
                            if (_fallbackFont == null)
                                _fallbackFont = new BitmapFont("biosFont", 8);
                            g = _fallbackFont._texture;
                        }
                        g.frame = num4;
                        g.scale = scale;
                        g.color = c;
                        g.alpha = alpha;
                        Graphics.Draw(g, xpos + num2, ypos + num1 + characterYOffset, deep);
                        num2 += _tileSize * scale.x;
                    }
                }
            }
        }
    }
}
