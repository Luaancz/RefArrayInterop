// NativePart.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "NativePart.h"
#include <iostream>
#include <objbase.h>

int main()
{


    return 0;
}

struct Point
{
    double x;
    double y;
};

Point *sharedArray;

extern "C" __declspec(dllexport) void MyGetArray(Point **vertices, int *count)
{
    std::cout << "In C code: " << (*vertices)[0].x;
        
    sharedArray = (Point*)CoTaskMemAlloc(sizeof(Point) * 10);
    sharedArray[3].x = 42;
    sharedArray[9].x = 100;

    *vertices = sharedArray;
    *count = 10;
}