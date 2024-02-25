# FIRCe
FIRCe is a Free and Open Source IRC library, forked from [smIRCL][0], a (sm)all (IRC) (L)ibrary, designed to provide core functionality for IRCv3 in a lightweight and self-sustaining manner. FIRCe will handle an IRC connection and session state for you with minimal input and output, and can provide a very simple to integrate base for simple bots, whilst exposing the required properties to implement more complex features with ease.

Currently, smIRCL supports the following IRCv3 capabilities out of the box (though you may enable and implement handlers for additional ones):
 - `message-tags`
 - `away-notify`
 - `extended-join`
 - `multi-prefix`
 - `chghost`

## Documentation
For documentation of all library parts, and additional information such as **Getting Started**, please visit https://alexhorner.github.io/smIRCL

## Credit
An absolutely huge thanks to [@jesopo][1] for their incredibly large amount of technical IRC knowledge. This library would not have been possible without their assistance and support!
Huge thanks also go to [Alexander Horner][2] for creating the original library. This fork would not be possible without his work.

## Libera
Have a peek over at `##smIRCL` on `irc.libera.chat` if you'd like to talk!


[0]:  https://github.com/alexhorner/smIRCL
[1]:  https://github.com/jesopo
[2]:  https://github.com/alexhorner/
