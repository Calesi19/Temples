from django.shortcuts import render, HttpResponse
from .models import Temple

def home(request):
    temples = Temple.objects.all()
    return render(request, 'home.html', {"temples": temples})

def temple(request, temple_id):
    temple = Temple.objects.get(id=temple_id)
    return render(request, 'temple.html', {"temple": temple})

def templeshow(request, temple_id):
    temple = Temple.objects.get(id=temple_id)
    html = f"<div><h1>{temple.city}, {temple.country} Temple</h1></div>"
    return HttpResponse(html)

