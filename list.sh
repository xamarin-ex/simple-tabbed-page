#!/bin/sh
tree -P "*.cs|*.xaml" -I "bin|obj|lib|packages|Resources|Assets|assets|Screen" $1
