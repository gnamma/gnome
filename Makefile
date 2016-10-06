build:
	# Building
	mkdir -p out
	mcs -t:library -out:out/GNMLParser.dll *.cs
	mcs -r:out/GNMLParser.dll -out:out/Test.exe test/Test.cs

t:
	make build
	# Testing
	mono out/Test.exe
