# myapp/context_processors.py
from .models import Temple

def sidebar_data(request):
    temples = Temple.objects.all()  # Query your model
    return {'sidebar_data': temples}
