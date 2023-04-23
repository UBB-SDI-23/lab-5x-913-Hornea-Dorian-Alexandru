import { CssBaseline, Container, Typography } from "@mui/material";
import React from "react";

export const HomePage = () => {
    return (
        <React.Fragment>
            <CssBaseline />
            <Container maxWidth="sm">
                <Typography variant="h2" component="h1" gutterBottom>
                    Home Page
                </Typography>
                </Container>
        </React.Fragment>
    );
};