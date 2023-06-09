import {useState} from 'react';
import CssBaseline from '@mui/material/CssBaseline';
import Box from '@mui/material/Box';
import Container from '@mui/material/Container';
import * as React from 'react';
import {AppBar, Toolbar, IconButton, Typography, Button} from '@mui/material';
import MenuIcon from "@mui/icons-material/Menu";
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import {HomePage} from './components/HomePage';
import { AppMenu } from './components/AppMenu';
import { GetAllAlbums } from './components/albums/GetAllAlbums';
import { AlbumDetails} from './components/albums/GetAlbum';
import { DeleteAlbum } from './components/albums/DeleteAlbum';
import { AddAlbum } from './components/albums/AddAlbum';
import { UpdateAlbum } from './components/albums/UpdateAlbum';
import { FilterAlbumsByPrice } from './components/albums/AlbumFilter';

function App(){
    return(
        <React.Fragment>
            <Router>
                <AppMenu />

                <Routes>
                    <Route path="/" element={<HomePage />} />
                    <Route path="/albums" element={<GetAllAlbums />} />
                    <Route path="/albums/:albumId" element={<FilterAlbumsByPrice />} />

                    <Route path="/albums/:albumId/details" element={<AlbumDetails />} />
                    <Route path="/albums/:albumId/delete" element={<DeleteAlbum />} />
                    <Route path="/albums/:albumId/edit" element={<UpdateAlbum />} />
                    <Route path="/albums/add" element={<AddAlbum />} />
                </Routes>
            </Router>
        </React.Fragment>
    );
}

export default App;