from django.shortcuts import render, HttpResponse
from .models import Temple

def home(request):
    temples = Temple.objects.all()
    return render(request, 'home.html', {"temples": temples})

def templelist(request):
    temples = Temple.objects.all()
    return render(request, 'templelist.html', {"temples": temples})

def temple(request, temple_id):
    temple = Temple.objects.get(id=temple_id)
    return render(request, 'temple.html', {"temple": temple})