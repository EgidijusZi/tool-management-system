import { useContext, React } from 'react';
import { Box, MenuItem, Menu, Paper } from '@mui/material';
import SettingsOutlinedIcon from '@mui/icons-material/SettingsOutlined';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import { useState } from 'react';
import { Stack } from '@mui/system';
import { AuthContext } from '../../hooks/AuthContext';
import ChangePasswordDialog from './ChangePasswordDialog';

const Header = () => {
  const [open, setOpen] = useState(false);
  const [menuOpen, setMenuOpen] = useState(false);
  const [anchorEl, setAnchorEl] = useState(null);

  const { signout } = useContext(AuthContext)

  const handleMenuOpen = (event) => {
    setAnchorEl(event.currentTarget);
    if (!menuOpen) {
      setMenuOpen(true);
    }
  };

  const handleMenuClose = () => {
    if (menuOpen) {
      setMenuOpen(false)
    }
  };

  const handleChangePassword = () => {
    //will be implemented later
    setMenuOpen(false);
  };

  const handleOpen = () => {
    setOpen(true);
  }

  const handleClose = () => {
    setOpen(false);
  }

  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'space-between',
        p: 1,
        backgroundColor: '#274b69',
      }}
    >
      <Typography variant='h4' sx={{ color: 'white', ml: 1 }}>
        Tool Management System
      </Typography>
      <Box sx={{ display: 'flex' }}>
        <IconButton onClick={handleMenuOpen} type='button' sx={{ p: 1 }}>
          <SettingsOutlinedIcon sx={{ color: 'white' }} />
          {menuOpen ? (
            <Stack direction='row' spacing={2}>
              <Paper>
                <Menu
                  open={menuOpen}
                  onClose={handleMenuClose}
                  anchorEl={anchorEl}
                >
                  <MenuItem onClick={handleOpen}>
                    Change Password
                  </MenuItem>
                  <MenuItem onClick={signout}>Signout</MenuItem>
                </Menu>
              </Paper>
            </Stack>
          ) : null}
          {open && <ChangePasswordDialog open={open} onDialogClose={handleClose} />}
        </IconButton>
      </Box>
    </Box>
  );
};

export default Header;
