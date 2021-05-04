#pragma once

#ifdef MATHLIBRARYCPLUSPLUS_EXPORTS
#define MATHLIBRARYCPLUSPLUS_API __declspec(dllexport)
#else
#define MATHLIBRARYCPLUSPLUS_API __declspec(dllimport)
#endif

extern "C" MATHLIBRARYCPLUSPLUS_API double add(double a, double b);
extern "C" MATHLIBRARYCPLUSPLUS_API double substract(double a, double b);
extern "C" MATHLIBRARYCPLUSPLUS_API double multiply(double a, double b);
extern "C" MATHLIBRARYCPLUSPLUS_API double divide(double a, double b);
