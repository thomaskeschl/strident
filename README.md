strident
========
A C# algorithmic noise generator.

Credit
------
I can hardly take any credit at all for this project, as I relied heavily on external sources. The first was a paper titled [*Simplex noise demystified*](http://webstaff.itn.liu.se/~stegu/simplexnoise/simplexnoise.pdf) by Stefan Gustavson, which is perhaps **the** resource for understanding noise algorithms. I'm shamelessly rewriting his algorithm in C#. Eventually, I want to add multiple passes in order to move from static noise to blobby islands, so at that point I'll probably end up departing from Gustavson's algorithm.

The second resouce I used was a really well written tutorial about dealing with WritableBitmaps available [here](http://www.i-programmer.info/programming/wpf-workings/527-writeablebitmap.html). I was rather in the dark about how to draw using writable bitmaps, and the MSDN documentation was horrid, but this article really shines. I used this implementation of the setPixel() extension method in order to make the noise display code much simpler.
